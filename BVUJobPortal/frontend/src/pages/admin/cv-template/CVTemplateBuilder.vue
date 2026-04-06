<template>
  <div class="flex h-screen bg-gray-100">
    <div class="w-64 bg-white border-r shadow-lg p-4 space-y-5">

      <div>
        <h2 class="font-bold text-[15px] mb-3">🧱 Khối nội dung</h2>

        <label class="block text-xs font-medium mb-1">Tên template</label>
        <input
          v-model="templateName"
          class="w-full border rounded-lg px-3 py-2 text-sm focus:ring focus:ring-blue-200 outline-none"
          placeholder="Nhập tên template..."
        />

        <label class="block text-xs font-medium mt-4 mb-1">Mô tả</label>
        <textarea
          v-model="templateDescription"
          rows="2"
          class="w-full border rounded-lg px-3 py-2 text-sm focus:ring focus:ring-blue-200 outline-none"
          placeholder="Mô tả ngắn..."
        ></textarea>
      </div>

      <hr class="border-gray-200" />

      <div class="max-h-[300px] overflow-y-auto pr-1 space-y-2 custom-scroll">

        <div
          v-for="b in blockLibrary"
          :key="b.type"
          class="flex items-center gap-3 px-3 py-2 rounded-xl border bg-gray-50 
                hover:bg-blue-50 hover:border-blue-400 transition-all cursor-pointer group"
          @click="addBlock(b.type)"
        >
          <div class="w-9 h-9 flex items-center justify-center rounded-lg bg-white shadow group-hover:scale-110 transition">
            <span class="text-lg">{{ b.icon }}</span>
          </div>

          <div class="flex flex-col leading-tight">
            <span class="font-semibold text-[14px] text-gray-800">{{ b.label }}</span>
            <span class="text-[11px] text-gray-500">{{ b.desc }}</span>
          </div>
        </div>

      </div>


      <hr class="border-gray-200" />

      <div>
        <h2 class="font-bold text-[15px] mb-3">🎨 Style chung</h2>

        <label class="block text-xs font-medium mb-1">Màu chủ đạo</label>
        <input
          type="color"
          v-model="style.primaryColor"
          class="w-full h-10 rounded border"
        />

        <label class="block text-xs font-medium mt-4 mb-1">Font chữ</label>
        <select
          v-model="style.font"
          class="w-full border rounded-lg px-2 py-2 text-sm"
        >
          <option>Inter</option>
          <option>Arial</option>
          <option>Segoe UI</option>
          <option>Roboto</option>
        </select>
      </div>

      <button
        class="mt-4 w-full py-3 bg-blue-600 text-white rounded-xl text-sm font-semibold hover:bg-blue-700 transition-all shadow"
        @click="saveTemplate"
      >
        💾 Lưu template
      </button>
    </div>

    <div class="flex-1 overflow-auto flex justify-center p-4 bg-gray-50" ref="canvasWrapper">
      <div
        ref="canvasRef"
        class="relative bg-white shadow-2xl border border-gray-300 origin-top"
        :style="{
          width: A4.width + 'px',
          height: A4.height + 'px',
          minWidth: A4.width + 'px',
          minHeight: A4.height + 'px',
          transform: `scale(${zoom})`,
        }"
      >
        <div
          class="absolute inset-0 pointer-events-none"
          style="
            background-image: linear-gradient(to right, #f3f4f6 1px, transparent 1px),
                              linear-gradient(to bottom, #f3f4f6 1px, transparent 1px);
            background-size: 16px 16px;
          "
        ></div>

        <div
          v-for="block in blocks"
          :key="block.id"
          class="absolute bg-white shadow-md border rounded-lg overflow-hidden group"
          :data-block-id="block.id"
          :style="{
            left: block.x + 'px',
            top: block.y + 'px',
            width: block.width + 'px',
            height: block.height + 'px',
            zIndex: block.zIndex,
          }"
          @mousedown.stop="selectBlock(block)"
        >
          <div
            class="flex items-center justify-between px-2 py-1 text-xs bg-gray-50 border-b cursor-move drag-handle"
            :style="{ backgroundColor: selectedBlock?.id === block.id ? '#e0f2fe' : '#f9fafb' }"
          >
            <span class="font-semibold truncate">
              {{ getBlockLabel(block.type) }}
            </span>
            <button
              class="opacity-0 group-hover:opacity-100 text-red-500 hover:text-red-600"
              @click.stop="removeBlock(block.id)"
            >
              ✕
            </button>
          </div>

          <div class="p-2 w-full h-full overflow-hidden text-xs">
            <div
              v-if="block.type === 'header'"
              class="h-full flex flex-col justify-center"
            >
              <div
                class="font-bold"
                :style="{
                  fontSize: (block.props.fontSize || 24) + 'px',
                  color: block.props.color || '#111827',
                  textAlign: block.props.align || 'left',
                }"
              >
                {{ block.props.text || 'HỌ VÀ TÊN ỨNG VIÊN' }}
              </div>
              <div
                class="mt-1 text-[11px] text-gray-500"
                :style="{ textAlign: block.props.align || 'left' }"
              >
                {{ block.props.subText || 'Vị trí ứng tuyển / Mô tả ngắn' }}
              </div>
            </div>

            <div
              v-else-if="block.type === 'avatar'"
              class="w-full h-full flex items-center justify-center"
            >
              <img
                v-if="block.props.url"
                :src="block.props.url"
                class="w-full h-full"
                :style="{
                  borderRadius: (block.props.borderRadius ?? 50) + '%',
                  objectFit: block.props.objectFit || 'cover',
                }"
              />
              <div v-else class="text-gray-400 text-xs text-center">
                (Chưa chọn ảnh)
              </div>
            </div>

            <div
              v-else-if="block.type === 'contact'"
              class="h-full text-[11px] space-y-1"
            >
              <div
                class="font-semibold mb-1 uppercase"
                :style="{ color: style.primaryColor }"
              >
                📇 THÔNG TIN LIÊN HỆ
              </div>
              <div v-if="block.props.email">
                📧 {{ block.props.email }}
              </div>
              <div v-if="block.props.phone">
                📱 {{ block.props.phone }}
              </div>
              <div v-if="block.props.address">
                📍 {{ block.props.address }}
              </div>
              <div v-if="block.props.website">
                🌐 {{ block.props.website }}
              </div>

              <div v-if="!block.props.email && !block.props.phone && !block.props.address && !block.props.website"
                  class="text-gray-400">
                (Chưa cấu hình thông tin liên hệ mẫu)
              </div>
            </div>

            <div
              v-else-if="block.type === 'target'"
              class="h-full text-[11px]"
            >
              <div
                class="font-semibold mb-1 uppercase"
                :style="{ color: style.primaryColor }"
              >
                🎯 MỤC TIÊU NGHỀ NGHIỆP
              </div>
              <div class="text-gray-700 whitespace-pre-line">
                {{
                  block.props.text ||
                  'Mong muốn phát triển sự nghiệp trong môi trường chuyên nghiệp,\nđóng góp giá trị cho doanh nghiệp và không ngừng học hỏi.'
                }}
              </div>
            </div>

            <div v-else-if="block.type === 'education'" class="h-full text-[11px]">
              <div
                class="font-semibold mb-1 uppercase"
                :style="{
                  fontSize: (block.props.titleSize || 14) + 'px',
                  color: style.primaryColor,
                }"
              >
                🎓 HỌC VẤN
              </div>
              <div
                v-for="(edu, i) in block.props.items"
                :key="i"
                class="mb-1"
              >
                <div class="font-medium">
                  {{ edu.school || 'Trường Đại học BVU' }}
                </div>
                <div class="text-gray-600">
                  {{ edu.major || 'Chuyên ngành...' }} ·
                  {{ edu.time || '20xx - 20yy' }}
                </div>
                <div v-if="edu.desc" class="text-gray-500">
                  {{ edu.desc }}
                </div>
              </div>
              <div v-if="!block.props.items?.length" class="text-gray-400">
                (Chưa có mục học vấn mẫu)
              </div>
            </div>

            <div
              v-else-if="block.type === 'experience'"
              class="h-full text-[11px]"
            >
              <div
                class="font-semibold mb-1 uppercase"
                :style="{ color: style.primaryColor }"
              >
                💼 KINH NGHIỆM LÀM VIỆC
              </div>

              <div
                v-for="(exp, i) in block.props.items"
                :key="i"
                class="mb-2"
              >
                <div class="font-medium">
                  {{ exp.position || 'Vị trí công việc' }}
                  <span class="text-gray-500">
                    · {{ exp.company || 'Tên công ty' }}
                  </span>
                </div>
                <div class="text-gray-500 text-[10px]">
                  {{ exp.time || '20xx - Nay' }}
                </div>
                <div v-if="exp.desc" class="text-gray-700">
                  - {{ exp.desc }}
                </div>
              </div>

              <div v-if="!block.props.items?.length" class="text-gray-400">
                (Chưa có kinh nghiệm mẫu)
              </div>
            </div>

            <div
              v-else-if="block.type === 'skills'"
              class="h-full text-[11px]"
            >
              <div
                class="font-semibold mb-1 uppercase"
                :style="{
                  fontSize: (block.props.titleSize || 14) + 'px',
                  color: style.primaryColor,
                }"
              >
                🛠 KỸ NĂNG
              </div>

              <div v-if="Array.isArray(block.props.items)" class="flex flex-wrap gap-1">
                <span
                  v-for="(skill, i) in block.props.items"
                  :key="i"
                  class="px-2 py-1 border rounded-lg bg-gray-50"
                >
                  {{ typeof skill === 'string' ? skill : skill.name || skill.tenKyNang || 'Kỹ năng' }}
                </span>
                <span v-if="!block.props.items.length" class="text-gray-400">
                  (Chưa có kỹ năng mẫu)
                </span>
              </div>

              <div
                v-else-if="block.props.list && block.props.list.length"
                class="space-y-1"
              >
                <div
                  v-for="(skill, i) in block.props.list"
                  :key="i"
                  class="flex items-center justify-between"
                >
                  <span>{{ skill.name || 'Kỹ năng' }}</span>
                  <span class="text-gray-500 text-[10px]">
                    {{ skill.level || 'Trung bình' }}
                  </span>
                </div>
              </div>
            </div>

            <div
              v-else-if="block.type === 'project'"
              class="h-full text-[11px]"
            >
              <div
                class="font-semibold mb-1 uppercase"
                :style="{ color: style.primaryColor }"
              >
                📂 DỰ ÁN TIÊU BIỂU
              </div>

              <div
                v-for="(p, i) in block.props.items"
                :key="i"
                class="mb-2"
              >
                <div class="font-medium">
                  {{ p.name || 'Tên dự án' }}
                </div>
                <div class="text-gray-500 text-[10px]">
                  Vai trò: {{ p.role || 'Thành viên nhóm / Leader' }}
                </div>
                <div v-if="p.tech" class="text-gray-500 text-[10px]">
                  Công nghệ: {{ p.tech }}
                </div>
                <div v-if="p.desc" class="text-gray-700">
                  - {{ p.desc }}
                </div>
              </div>

              <div v-if="!block.props.items?.length" class="text-gray-400">
                (Chưa có dự án mẫu)
              </div>
            </div>

            <div
              v-else-if="block.type === 'certificate'"
              class="h-full text-[11px]"
            >
              <div
                class="font-semibold mb-1 uppercase"
                :style="{ color: style.primaryColor }"
              >
                📜 CHỨNG CHỈ
              </div>

              <div
                v-for="(c, i) in block.props.items"
                :key="i"
                class="mb-1"
              >
                <div class="font-medium">
                  {{ c.name || 'Tên chứng chỉ' }}
                </div>
                <div class="text-gray-500 text-[10px]">
                  {{ c.issuer || 'Đơn vị cấp' }}
                  <span v-if="c.date">
                    · {{ c.date }}
                  </span>
                </div>
              </div>

              <div v-if="!block.props.items?.length" class="text-gray-400">
                (Chưa có chứng chỉ mẫu)
              </div>
            </div>

            <div
              v-else-if="block.type === 'activity'"
              class="h-full text-[11px]"
            >
              <div
                class="font-semibold mb-1 uppercase"
                :style="{ color: style.primaryColor }"
              >
                🤝 HOẠT ĐỘNG
              </div>

              <div
                v-for="(a, i) in block.props.items"
                :key="i"
                class="mb-1"
              >
                <div class="font-medium">
                  {{ a.name || 'Tên hoạt động / CLB' }}
                </div>
                <div class="text-gray-500 text-[10px]">
                  {{ a.role || 'Thành viên' }}
                  <span v-if="a.time"> · {{ a.time }}</span>
                </div>
                <div v-if="a.desc" class="text-gray-700">
                  - {{ a.desc }}
                </div>
              </div>

              <div v-if="!block.props.items?.length" class="text-gray-400">
                (Chưa có hoạt động mẫu)
              </div>
            </div>

            <div
              v-else-if="block.type === 'award'"
              class="h-full text-[11px]"
            >
              <div
                class="font-semibold mb-1 uppercase"
                :style="{ color: style.primaryColor }"
              >
                🏆 GIẢI THƯỞNG
              </div>

              <div
                v-for="(aw, i) in block.props.items"
                :key="i"
                class="mb-1"
              >
                <div class="font-medium">
                  {{ aw.name || 'Tên giải thưởng' }}
                </div>
                <div class="text-gray-500 text-[10px]">
                  {{ aw.org || 'Đơn vị tổ chức' }}
                  <span v-if="aw.time"> · {{ aw.time }}</span>
                </div>
                <div v-if="aw.desc" class="text-gray-700">
                  - {{ aw.desc }}
                </div>
              </div>

              <div v-if="!block.props.items?.length" class="text-gray-400">
                (Chưa có giải thưởng mẫu)
              </div>
            </div>

            <div
              v-else-if="block.type === 'reference'"
              class="h-full text-[11px]"
            >
              <div
                class="font-semibold mb-1 uppercase"
                :style="{ color: style.primaryColor }"
              >
                👤 NGƯỜI THAM CHIẾU
              </div>

              <div
                v-for="(r, i) in block.props.items"
                :key="i"
                class="mb-2"
              >
                <div class="font-medium">
                  {{ r.name || 'Họ tên người tham chiếu' }}
                </div>
                <div class="text-gray-500 text-[10px]">
                  {{ r.position || 'Chức vụ' }},
                  {{ r.company || 'Đơn vị công tác' }}
                </div>
                <div class="text-gray-500 text-[10px]">
                  ☎ {{ r.phone || 'SĐT' }}
                  <span v-if="r.email"> · ✉ {{ r.email }}</span>
                </div>
              </div>

              <div v-if="!block.props.items?.length" class="text-gray-400">
                (Chưa có người tham chiếu mẫu)
              </div>
            </div>

            <div
              v-else-if="block.type === 'hobby'"
              class="h-full text-[11px]"
            >
              <div
                class="font-semibold mb-1 uppercase"
                :style="{ color: style.primaryColor }"
              >
                🎯 SỞ THÍCH
              </div>

              <ul class="list-disc ml-4">
                <li
                  v-for="(h, i) in block.props.items"
                  :key="i"
                >
                  {{ typeof h === 'string' ? h : h.text || 'Sở thích' }}
                </li>
              </ul>

              <div v-if="!block.props.items?.length" class="text-gray-400">
                (Chưa có sở thích mẫu)
              </div>
            </div>

            <div
              v-else-if="block.type === 'extra'"
              class="h-full text-[11px]"
            >
              <div
                class="font-semibold mb-1 uppercase"
                :style="{ color: style.primaryColor }"
              >
                📌 THÔNG TIN THÊM
              </div>
              <div class="text-gray-700 whitespace-pre-line">
                {{
                  block.props.text ||
                  'Những thông tin bổ sung khác: tình trạng hôn nhân, mong muốn công việc, thời gian làm việc,...'
                }}
              </div>
            </div>

            <div
              v-else-if="block.type === 'text'"
              class="h-full text-gray-700 whitespace-pre-line"
              :style="{
                fontSize: (block.props.fontSize || 12) + 'px',
                color: block.props.color || '#374151',
                textAlign: block.props.align || 'left',
              }"
            >
              {{ block.props.text || 'Nhập nội dung mô tả...' }}
            </div>

            <div
              v-else
              class="h-full flex items-center justify-center text-gray-400"
            >
              Block: {{ block.type }}
            </div>
          </div>

          <div
            class="absolute bottom-0 right-0 w-3 h-3 bg-blue-500 rounded-tr-lg cursor-se-resize"
          ></div>
        </div>
      </div>
    </div>

    <div class="w-80 bg-white border-l shadow-lg p-4 space-y-4">
      <h2 class="font-bold text-lg mb-2">🛠 Thuộc tính block</h2>

      <div v-if="!selectedBlock" class="text-gray-400 text-sm">
        Chọn một block trên canvas để chỉnh sửa.
      </div>

      <div v-else-if="selectedBlock.type === 'header'" class="space-y-3 text-sm">
        <div>
          <label class="block mb-1">Tiêu đề</label>
          <input
            v-model="selectedBlock.props.text"
            class="w-full border rounded px-2 py-1"
            placeholder="HỌ VÀ TÊN"
          />
        </div>

        <div>
          <label class="block mb-1">Dòng phụ</label>
          <input
            v-model="selectedBlock.props.subText"
            class="w-full border rounded px-2 py-1"
            placeholder="Vị trí ứng tuyển / Mô tả ngắn"
          />
        </div>

        <div class="flex gap-2">
          <div class="flex-1">
            <label class="block mb-1">Cỡ chữ</label>
            <input
              type="number"
              v-model.number="selectedBlock.props.fontSize"
              class="w-full border rounded px-2 py-1"
              min="10"
              max="40"
            />
          </div>
          <div class="flex-1">
            <label class="block mb-1">Màu chữ</label>
            <input type="color" v-model="selectedBlock.props.color" class="w-full h-9" />
          </div>
        </div>

        <div>
          <label class="block mb-1">Căn lề</label>
          <select
            v-model="selectedBlock.props.align"
            class="w-full border rounded px-2 py-1"
          >
            <option value="left">Trái</option>
            <option value="center">Giữa</option>
            <option value="right">Phải</option>
          </select>
        </div>
      </div>

      <div v-else-if="selectedBlock.type === 'text'" class="space-y-3 text-sm">
        <div>
          <label class="block mb-1">Nội dung</label>
          <textarea
            v-model="selectedBlock.props.text"
            rows="6"
            class="w-full border rounded px-2 py-1"
          ></textarea>
        </div>

        <div class="flex gap-2">
          <div class="flex-1">
            <label class="block mb-1">Cỡ chữ</label>
            <input
              type="number"
              v-model.number="selectedBlock.props.fontSize"
              class="w-full border rounded px-2 py-1"
              min="10"
              max="24"
            />
          </div>
          <div class="flex-1">
            <label class="block mb-1">Màu chữ</label>
            <input type="color" v-model="selectedBlock.props.color" class="w-full h-9" />
          </div>
        </div>

        <div>
          <label class="block mb-1">Căn lề</label>
          <select
            v-model="selectedBlock.props.align"
            class="w-full border rounded px-2 py-1"
          >
            <option value="left">Trái</option>
            <option value="center">Giữa</option>
            <option value="right">Phải</option>
          </select>
        </div>
      </div>

      <div v-else-if="selectedBlock.type === 'education'" class="space-y-3 text-sm">
        <div>
          <label class="block mb-1">Cỡ chữ tiêu đề</label>
          <input
            type="number"
            v-model.number="selectedBlock.props.titleSize"
            class="w-full border rounded px-2 py-1"
            min="10"
            max="24"
          />
        </div>

        <div class="space-y-2">
          <div
            v-for="(edu, i) in selectedBlock.props.items"
            :key="i"
            class="border rounded p-2 space-y-1"
          >
            <input
              v-model="edu.school"
              class="w-full border rounded px-2 py-1"
              placeholder="Trường"
            />
            <input
              v-model="edu.major"
              class="w-full border rounded px-2 py-1"
              placeholder="Chuyên ngành"
            />
            <input
              v-model="edu.time"
              class="w-full border rounded px-2 py-1"
              placeholder="Thời gian (VD: 2020-2024)"
            />
            <button
              class="text-xs text-red-500 hover:underline"
              @click="removeEdu(i)"
            >
              Xóa
            </button>
          </div>

          <button
            class="w-full border rounded py-1 hover:bg-gray-50 text-xs"
            @click="addEdu"
          >
            ➕ Thêm dòng học vấn
          </button>
        </div>
      </div>

      <div v-else-if="selectedBlock.type === 'skills'" class="space-y-3 text-sm">
        <div>
          <label class="block mb-1">Cỡ chữ tiêu đề</label>
          <input
            type="number"
            v-model.number="selectedBlock.props.titleSize"
            class="w-full border rounded px-2 py-1"
            min="10"
            max="24"
          />
        </div>
        <div class="flex gap-2">
          <input
            v-model="newSkill"
            class="flex-1 border rounded px-2 py-1"
            placeholder="Nhập kỹ năng..."
            @keyup.enter="addSkill"
          />
          <button
            class="px-3 py-1 bg-blue-500 text-white rounded text-sm"
            @click="addSkill"
          >
            +
          </button>
        </div>

        

        <div class="flex flex-wrap gap-2">
          <div
            v-for="(skill, i) in selectedBlock.props.items"
            :key="i"
            class="px-2 py-1 border rounded flex items-center gap-1 bg-gray-50 text-xs"
          >
            {{ skill }}
            <button class="text-red-500" @click="removeSkill(i)">x</button>
          </div>
        </div>
      </div>

      <div v-else-if="selectedBlock.type === 'avatar'" class="space-y-3 text-sm">
        <div>
          <label class="block mb-1">Chọn ảnh</label>
          <input type="file" accept="image/*" @change="onAvatarChange" />
        </div>

        <div>
          <label class="block mb-1">Bo góc (%)</label>
          <input
            type="range"
            min="0"
            max="50"
            v-model.number="selectedBlock.props.borderRadius"
            class="w-full"
          />
        </div>

        <div>
          <label class="block mb-1">Kiểu hiển thị</label>
          <select
            v-model="selectedBlock.props.objectFit"
            class="w-full border rounded px-2 py-1"
          >
            <option value="cover">Cover</option>
            <option value="contain">Contain</option>
            <option value="fill">Fill</option>
          </select>
        </div>
      </div>

      <div v-else class="text-gray-400 text-sm">
        Loại block này chưa có panel chỉnh riêng.
      </div>
    </div>
  </div>
<div
  class="fixed bottom-6 right-6 bg-white shadow-xl rounded-xl p-3 flex flex-col items-center gap-2 border z-[999]"
>
  <button
    class="w-8 h-8 flex items-center justify-center bg-gray-100 rounded hover:bg-gray-200"
    @click="zoom = Math.max(0.3, zoom - 0.1)"
  >
    −
  </button>

  <div class="text-sm font-semibold select-none">
    {{ Math.round(zoom * 100) }}%
  </div>

  <button
    class="w-8 h-8 flex items-center justify-center bg-gray-100 rounded hover:bg-gray-200"
    @click="zoom = Math.min(2, zoom + 0.1)"
  >
    +
  </button>
</div>

</template>

<script setup>
import { ref, onMounted, watch } from "vue";
import { useRoute, useRouter } from "vue-router";
import interact from "interactjs";
import api from "@/api/axios";
import { useToast } from "vue-toastification";
import html2canvas from "html2canvas";

const toast = useToast();
const route = useRoute();
const router = useRouter();

const templateId = route.params.id;

const A4 = { width: 794, height: 1123 };

const canvasRef = ref(null);
const canvasWrapper = ref(null);

const templateName = ref("Template mới");
const templateDescription = ref("");

const blockLibrary = [
  { type: "avatar", label: "Ảnh đại diện", icon: "🖼️" },
  { type: "header", label: "Danh thiếp (Họ tên - Vị trí)", icon: "👤" },
  { type: "contact", label: "Thông tin liên hệ", icon: "📞" },
  { type: "target", label: "Mục tiêu nghề nghiệp", icon: "🎯" },
  { type: "education", label: "Học vấn", icon: "🎓" },
  { type: "experience", label: "Kinh nghiệm", icon: "💼" },
  { type: "skills", label: "Kỹ năng", icon: "🛠️" },
  { type: "certificate", label: "Chứng chỉ", icon: "📜" },
  { type: "project", label: "Dự án", icon: "📂" },
  { type: "activity", label: "Hoạt động", icon: "🏅" },
  { type: "award", label: "Giải thưởng", icon: "🏆" },
  { type: "reference", label: "Người tham chiếu", icon: "👥" },
  { type: "hobby", label: "Sở thích", icon: "🎧" },
  { type: "extra", label: "Thông tin thêm", icon: "➕" },
  { type: "text", label: "Khối văn bản tuỳ ý", icon: "✏️" }
];

const blocks = ref([]);
const style = ref({
  primaryColor: "#0A66C2",
  font: "Inter",
});

const selectedBlock = ref(null);
const newSkill = ref("");

function getBlockLabel(type) {
  return blockLibrary.find((x) => x.type === type)?.label || type;
}

function addBlock(type) {
  const offset = blocks.value.length * 20;

const defaultProps = {
  header: { hoTen: "NGUYỄN VĂN A", viTri: "Ứng tuyển..." },

  contact: {
    email: "email@example.com",
    phone: "0123456789",
    address: "TP. Vũng Tàu",
    website: ""
  },

  target: {
    text: "Mục tiêu ngắn hạn và dài hạn..."
  },

  experience: {
    items: [
      { congTy: "Công ty ABC", viTri: "Thực tập sinh", moTa: "", thoiGian: "2023" }
    ]
  },

  project: {
    items: [
      { ten: "Website bán hàng", vaiTro: "Dev", moTa: "React + .NET", thoiGian: "2024" }
    ]
  },

  certificate: {
    items: [
      { ten: "IELTS 6.5", thoiGian: "2024", noiCap: "British Council" }
    ]
  },

  activity: {
    items: [
      { ten: "CLB IT BVU", vaiTro: "Thành viên", moTa: "" }
    ]
  },

  award: {
    items: [
      { ten: "Sinh viên 5 tốt", thoiGian: "2023" }
    ]
  },

  reference: {
    items: [
      { ten: "Nguyễn Văn B", chucVu: "Quản lý", congTy: "XYZ", sdt: "", email: "" }
    ]
  },

  hobby: {
    items: ["Đọc sách", "Chạy bộ", "Chụp ảnh"]
  },

  extra: {
    text: "Thông tin thêm…"
  },

  text: { text: "Nội dung..." },
  avatar: { url: "", borderRadius: 50, objectFit: "cover" },
  education: {
    items: [
      { truong: "Đại học BVU", chuyenNganh: "IT", thoiGian: "2020–2024" }
    ]
  },
  skills: {
    items: ["Teamwork", "Giao tiếp"]
  }
};


  const sizeDefaults = {
    header: { width: 500, height: 90 },
    avatar: { width: 140, height: 140 },
    contact: { width: 350, height: 140 },
    target: { width: 450, height: 120 },
    education: { width: 450, height: 160 },
    experience: { width: 500, height: 180 },
    project: { width: 500, height: 180 },
    skills: { width: 350, height: 120 },
    certificate: { width: 420, height: 120 },
    activity: { width: 450, height: 140 },
    award: { width: 420, height: 120 },
    reference: { width: 420, height: 160 },
    hobby: { width: 300, height: 120 },
    extra: { width: 450, height: 120 },
    text: { width: 400, height: 100 },
  };


  const block = {
    id: Date.now().toString(),
    type,
    x: 40 + offset,
    y: 40 + offset,
    width: sizeDefaults[type]?.width || 300,
    height: sizeDefaults[type]?.height || 100,
    zIndex: blocks.value.length + 1,
    props: defaultProps[type],
  };

  blocks.value.push(block);
  selectedBlock.value = block;

  nextTickInteract();
}

function removeBlock(id) {
  blocks.value = blocks.value.filter((b) => b.id !== id);
  if (selectedBlock.value?.id === id) selectedBlock.value = null;
}

function selectBlock(block) {
  selectedBlock.value = block;
  block.zIndex = Math.max(...blocks.value.map((b) => b.zIndex || 1)) + 1;
}

function fixAvatar(block) {
  if (block.type !== "avatar") return;

  if (block.props.url && !block.props.url.startsWith("data:") && !block.props.url.startsWith("http")) {
    block.props.url = "https://localhost:7248" + block.props.url;
  }
}

function onAvatarChange(e) {
  const file = e.target.files[0];
  if (!file || !selectedBlock.value) return;

  const reader = new FileReader();
  reader.onload = () => {
    selectedBlock.value.props.url = reader.result;
  };
  reader.readAsDataURL(file);
}

function addEdu() {
  selectedBlock.value.props.items.push({ school: "", major: "", time: "" });
}
function removeEdu(i) {
  selectedBlock.value.props.items.splice(i, 1);
}

function addSkill() {
  const text = newSkill.value.trim();
  if (!text) return;
  selectedBlock.value.props.items.push(text);
  newSkill.value = "";
}
function removeSkill(i) {
  selectedBlock.value.props.items.splice(i, 1);
}

function initInteract() {
  interact("[data-block-id]")
    .draggable({
      allowFrom: ".drag-handle",
      listeners: {
        move(event) {
          const id = event.target.getAttribute("data-block-id");
          const block = blocks.value.find((b) => b.id === id);
          if (!block) return;

          block.x += event.dx;
          block.y += event.dy;

          block.x = Math.max(0, Math.min(block.x, A4.width - block.width));
          block.y = Math.max(0, Math.min(block.y, A4.height - block.height));
        },
      },
    })
    .resizable({
      edges: { right: true, bottom: true },
      listeners: {
        move(event) {
          const id = event.target.getAttribute("data-block-id");
          const block = blocks.value.find((b) => b.id === id);
          if (!block) return;

          block.width = Math.max(120, block.width + event.deltaRect.width);
          block.height = Math.max(60, block.height + event.deltaRect.height);

          block.width = Math.min(block.width, A4.width - block.x);
          block.height = Math.min(block.height, A4.height - block.y);
        },
      },
    });
}

function nextTickInteract() {
  setTimeout(() => initInteract(), 10);
}

onMounted(async () => {
  const wrapper = canvasWrapper.value;
  wrapper.addEventListener("wheel", (e) => {
    if (!e.ctrlKey) return;
    e.preventDefault();
    setZoom(zoom.value + (e.deltaY < 0 ? 0.05 : -0.05));
  });

  if (templateId) {
    try {
      const res = await api.get(`/admin/cv-templates/${templateId}`);
      const t = res.data;

      templateName.value = t.tenTemplate || "Không tên";
      templateDescription.value = t.moTa || "";

      style.value.primaryColor = t.mauChuDao || "#0A66C2";
      style.value.font = t.font || "Inter";

      if (t.layoutJson) {
        const parsed = JSON.parse(t.layoutJson);
        blocks.value = parsed.blocks.map((b) => {
          fixAvatar(b);
          return { ...b, props: { ...b.props } };
        });
      }

      toast.success("Đang chỉnh sửa template");
    } catch (e) {
      toast.error("Không tải được template!");
    }
  }

  nextTickInteract();
});

watch(
  () => blocks.value,
  () => nextTickInteract(),
  { deep: true }
);

const zoom = ref(1);
function setZoom(val) {
  zoom.value = Math.max(0.3, Math.min(2, val));
}

window.addEventListener("keydown", (e) => {
  if (e.ctrlKey && e.key === "0") {
    e.preventDefault();
    zoom.value = 1;
  }
});

async function saveTemplate() {
  const preview = await generatePreview();

  const payload = {
    tenTemplate: templateName.value,
    moTa: templateDescription.value,
    previewUrl: preview,
    mauChuDao: style.value.primaryColor,
    font: style.value.font,
    layoutJson: JSON.stringify({ blocks: blocks.value }),
    styleJson: JSON.stringify(style.value),
    isPublished: false,
  };

  try {
    if (templateId) {
      await api.put(`/admin/cv-templates/${templateId}`, payload);
      toast.success("Đã cập nhật template!");
    } else {
      const res = await api.post("/admin/cv-templates", payload);
      toast.success("Đã tạo template!");
      router.replace(`/admin/cv-template/builder/${res.data.id}`);
    }
  } catch (e) {
    toast.error("Lưu template thất bại!");
  }
}

async function generatePreview() {
  const canvas = canvasRef.value;
  if (!canvas) return "";

  const imgCanvas = await html2canvas(canvas, { scale: 2, useCORS: true });
  return imgCanvas.toDataURL("image/png");
}
</script>

<style scoped>
.block-item {
  @apply w-full flex items-center gap-3 px-3 py-2 rounded-lg border 
         bg-white shadow-sm transition cursor-pointer select-none;
}

.block-item:hover {
  @apply bg-blue-50 border-blue-300 shadow-md;
}

.block-icon {
  @apply w-8 h-8 flex items-center justify-center rounded-lg text-xl;
  background: linear-gradient(135deg, #fff, #f3f4f6);
}
.custom-scroll::-webkit-scrollbar {
  width: 6px;
}

.custom-scroll::-webkit-scrollbar-thumb {
  background: #cbd5e1;
  border-radius: 10px;
}

.custom-scroll::-webkit-scrollbar-thumb:hover {
  background: #94a3b8;
}

</style>

