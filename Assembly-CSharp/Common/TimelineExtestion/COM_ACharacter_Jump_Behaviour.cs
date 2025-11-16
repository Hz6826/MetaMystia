using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Common.TimelineExtestion
{
	// Token: 0x0200042B RID: 1067
	public class COM_ACharacter_Jump_Behaviour : ExtendedPlayableBehaviour
	{
		// Token: 0x060078A6 RID: 30886 RVA: 0x0022F3C4 File Offset: 0x0022D5C4
		// Note: this type is marked as 'beforefieldinit'.
		static COM_ACharacter_Jump_Behaviour()
		{
			Il2CppClassPointerStore<COM_ACharacter_Jump_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_ACharacter_Jump_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_ACharacter_Jump_Behaviour>.NativeClassPtr);
			COM_ACharacter_Jump_Behaviour.NativeFieldInfoPtr_gravity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_Jump_Behaviour>.NativeClassPtr, "gravity");
			COM_ACharacter_Jump_Behaviour.NativeFieldInfoPtr_jumpCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_Jump_Behaviour>.NativeClassPtr, "jumpCount");
			COM_ACharacter_Jump_Behaviour.NativeFieldInfoPtr_jumpHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_Jump_Behaviour>.NativeClassPtr, "jumpHeight");
			COM_ACharacter_Jump_Behaviour.NativeFieldInfoPtr_jumpInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_Jump_Behaviour>.NativeClassPtr, "jumpInterval");
			COM_ACharacter_Jump_Behaviour.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_Jump_Behaviour>.NativeClassPtr, "label");
			COM_ACharacter_Jump_Behaviour.NativeFieldInfoPtr_shouldWaitForFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_Jump_Behaviour>.NativeClassPtr, "shouldWaitForFinish");
			COM_ACharacter_Jump_Behaviour.NativeFieldInfoPtr_startPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_Jump_Behaviour>.NativeClassPtr, "startPoint");
			COM_ACharacter_Jump_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_Jump_Behaviour>.NativeClassPtr, 100687661);
			COM_ACharacter_Jump_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_Jump_Behaviour>.NativeClassPtr, 100687662);
		}

		// Token: 0x060078A7 RID: 30887 RVA: 0x0022F4A8 File Offset: 0x0022D6A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293692, XrefRangeEnd = 293704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_ACharacter_Jump_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078A8 RID: 30888 RVA: 0x0022F4E4 File Offset: 0x0022D6E4
		[CallerCount(201)]
		[CachedScanResults(RefRangeStart = 42926, RefRangeEnd = 43127, XrefRangeStart = 42926, XrefRangeEnd = 43127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_ACharacter_Jump_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_ACharacter_Jump_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_ACharacter_Jump_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078A9 RID: 30889 RVA: 0x00041409 File Offset: 0x0003F609
		public COM_ACharacter_Jump_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170028FF RID: 10495
		// (get) Token: 0x060078AA RID: 30890 RVA: 0x0022F520 File Offset: 0x0022D720
		// (set) Token: 0x060078AB RID: 30891 RVA: 0x00041412 File Offset: 0x0003F612
		public unsafe float gravity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Jump_Behaviour.NativeFieldInfoPtr_gravity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Jump_Behaviour.NativeFieldInfoPtr_gravity)) = value;
			}
		}

		// Token: 0x17002900 RID: 10496
		// (get) Token: 0x060078AC RID: 30892 RVA: 0x0022F548 File Offset: 0x0022D748
		// (set) Token: 0x060078AD RID: 30893 RVA: 0x0004142D File Offset: 0x0003F62D
		public unsafe int jumpCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Jump_Behaviour.NativeFieldInfoPtr_jumpCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Jump_Behaviour.NativeFieldInfoPtr_jumpCount)) = value;
			}
		}

		// Token: 0x17002901 RID: 10497
		// (get) Token: 0x060078AE RID: 30894 RVA: 0x0022F570 File Offset: 0x0022D770
		// (set) Token: 0x060078AF RID: 30895 RVA: 0x00041448 File Offset: 0x0003F648
		public unsafe float jumpHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Jump_Behaviour.NativeFieldInfoPtr_jumpHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Jump_Behaviour.NativeFieldInfoPtr_jumpHeight)) = value;
			}
		}

		// Token: 0x17002902 RID: 10498
		// (get) Token: 0x060078B0 RID: 30896 RVA: 0x0022F598 File Offset: 0x0022D798
		// (set) Token: 0x060078B1 RID: 30897 RVA: 0x00041463 File Offset: 0x0003F663
		public unsafe float jumpInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Jump_Behaviour.NativeFieldInfoPtr_jumpInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Jump_Behaviour.NativeFieldInfoPtr_jumpInterval)) = value;
			}
		}

		// Token: 0x17002903 RID: 10499
		// (get) Token: 0x060078B2 RID: 30898 RVA: 0x0022F5C0 File Offset: 0x0022D7C0
		// (set) Token: 0x060078B3 RID: 30899 RVA: 0x0004147E File Offset: 0x0003F67E
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Jump_Behaviour.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Jump_Behaviour.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002904 RID: 10500
		// (get) Token: 0x060078B4 RID: 30900 RVA: 0x0022F5E8 File Offset: 0x0022D7E8
		// (set) Token: 0x060078B5 RID: 30901 RVA: 0x0004149D File Offset: 0x0003F69D
		public unsafe bool shouldWaitForFinish
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Jump_Behaviour.NativeFieldInfoPtr_shouldWaitForFinish);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Jump_Behaviour.NativeFieldInfoPtr_shouldWaitForFinish)) = value;
			}
		}

		// Token: 0x17002905 RID: 10501
		// (get) Token: 0x060078B6 RID: 30902 RVA: 0x0022F610 File Offset: 0x0022D810
		// (set) Token: 0x060078B7 RID: 30903 RVA: 0x000414B8 File Offset: 0x0003F6B8
		public unsafe float startPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Jump_Behaviour.NativeFieldInfoPtr_startPoint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Jump_Behaviour.NativeFieldInfoPtr_startPoint)) = value;
			}
		}

		// Token: 0x04004F86 RID: 20358
		private static readonly IntPtr NativeFieldInfoPtr_gravity;

		// Token: 0x04004F87 RID: 20359
		private static readonly IntPtr NativeFieldInfoPtr_jumpCount;

		// Token: 0x04004F88 RID: 20360
		private static readonly IntPtr NativeFieldInfoPtr_jumpHeight;

		// Token: 0x04004F89 RID: 20361
		private static readonly IntPtr NativeFieldInfoPtr_jumpInterval;

		// Token: 0x04004F8A RID: 20362
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x04004F8B RID: 20363
		private static readonly IntPtr NativeFieldInfoPtr_shouldWaitForFinish;

		// Token: 0x04004F8C RID: 20364
		private static readonly IntPtr NativeFieldInfoPtr_startPoint;

		// Token: 0x04004F8D RID: 20365
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04004F8E RID: 20366
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
