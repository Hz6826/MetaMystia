using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace Common.UI
{
	// Token: 0x02000369 RID: 873
	public class ClockController : MonoBehaviour
	{
		// Token: 0x06006797 RID: 26519 RVA: 0x001F8290 File Offset: 0x001F6490
		// Note: this type is marked as 'beforefieldinit'.
		static ClockController()
		{
			Il2CppClassPointerStore<ClockController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI", "ClockController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClockController>.NativeClassPtr);
			ClockController.NativeFieldInfoPtr_xii = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClockController>.NativeClassPtr, "xii");
			ClockController.NativeFieldInfoPtr_i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClockController>.NativeClassPtr, "i");
			ClockController.NativeFieldInfoPtr_ii = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClockController>.NativeClassPtr, "ii");
			ClockController.NativeFieldInfoPtr_iii = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClockController>.NativeClassPtr, "iii");
			ClockController.NativeFieldInfoPtr_iv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClockController>.NativeClassPtr, "iv");
			ClockController.NativeFieldInfoPtr_v = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClockController>.NativeClassPtr, "v");
			ClockController.NativeFieldInfoPtr_vi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClockController>.NativeClassPtr, "vi");
			ClockController.NativeFieldInfoPtr_vii = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClockController>.NativeClassPtr, "vii");
			ClockController.NativeFieldInfoPtr_viii = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClockController>.NativeClassPtr, "viii");
			ClockController.NativeFieldInfoPtr_ix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClockController>.NativeClassPtr, "ix");
			ClockController.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClockController>.NativeClassPtr, "x");
			ClockController.NativeFieldInfoPtr_xi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClockController>.NativeClassPtr, "xi");
			ClockController.NativeFieldInfoPtr_timeInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClockController>.NativeClassPtr, "timeInterval");
			ClockController.NativeFieldInfoPtr_minuteInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClockController>.NativeClassPtr, "minuteInterval");
			ClockController.NativeFieldInfoPtr_needle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClockController>.NativeClassPtr, "needle");
			ClockController.NativeFieldInfoPtr_timeSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClockController>.NativeClassPtr, "timeSFX");
			ClockController.NativeFieldInfoPtr_currentClock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClockController>.NativeClassPtr, "currentClock");
			ClockController.NativeFieldInfoPtr_startClock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClockController>.NativeClassPtr, "startClock");
			ClockController.NativeFieldInfoPtr_finishClock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClockController>.NativeClassPtr, "finishClock");
			ClockController.NativeMethodInfoPtr_set_Needle_Private_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClockController>.NativeClassPtr, 100684933);
			ClockController.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClockController>.NativeClassPtr, 100684934);
			ClockController.NativeMethodInfoPtr_Initialize_Public_Void_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClockController>.NativeClassPtr, 100684935);
			ClockController.NativeMethodInfoPtr_SetNeedle_Private_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClockController>.NativeClassPtr, 100684936);
			ClockController.NativeMethodInfoPtr_SetProgress_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClockController>.NativeClassPtr, 100684937);
			ClockController.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClockController>.NativeClassPtr, 100684938);
			ClockController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClockController>.NativeClassPtr, 100684939);
		}

		// Token: 0x17002398 RID: 9112
		// (set) Token: 0x06006798 RID: 26520 RVA: 0x001F84C8 File Offset: 0x001F66C8
		public unsafe Sprite Needle
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266527, XrefRangeEnd = 266529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClockController.NativeMethodInfoPtr_set_Needle_Private_set_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006799 RID: 26521 RVA: 0x001F850C File Offset: 0x001F670C
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClockController.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600679A RID: 26522 RVA: 0x001F8540 File Offset: 0x001F6740
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 266536, RefRangeEnd = 266538, XrefRangeStart = 266529, XrefRangeEnd = 266536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(byte startClock, byte finishClock)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref startClock;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref finishClock;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClockController.NativeMethodInfoPtr_Initialize_Public_Void_Byte_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600679B RID: 26523 RVA: 0x001F858C File Offset: 0x001F678C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 266539, RefRangeEnd = 266541, XrefRangeStart = 266538, XrefRangeEnd = 266539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNeedle(byte clockCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref clockCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClockController.NativeMethodInfoPtr_SetNeedle_Private_Void_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600679C RID: 26524 RVA: 0x001F85CC File Offset: 0x001F67CC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 266565, RefRangeEnd = 266571, XrefRangeStart = 266541, XrefRangeEnd = 266565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetProgress(float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClockController.NativeMethodInfoPtr_SetProgress_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600679D RID: 26525 RVA: 0x001F860C File Offset: 0x001F680C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266571, XrefRangeEnd = 266587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClockController.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600679E RID: 26526 RVA: 0x001F8648 File Offset: 0x001F6848
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClockController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClockController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClockController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600679F RID: 26527 RVA: 0x00037FFD File Offset: 0x000361FD
		public ClockController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002385 RID: 9093
		// (get) Token: 0x060067A0 RID: 26528 RVA: 0x001F8684 File Offset: 0x001F6884
		// (set) Token: 0x060067A1 RID: 26529 RVA: 0x00038006 File Offset: 0x00036206
		public unsafe Sprite xii
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClockController.NativeFieldInfoPtr_xii);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClockController.NativeFieldInfoPtr_xii), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002386 RID: 9094
		// (get) Token: 0x060067A2 RID: 26530 RVA: 0x001F86B4 File Offset: 0x001F68B4
		// (set) Token: 0x060067A3 RID: 26531 RVA: 0x00038025 File Offset: 0x00036225
		public unsafe Sprite i
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClockController.NativeFieldInfoPtr_i);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClockController.NativeFieldInfoPtr_i), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002387 RID: 9095
		// (get) Token: 0x060067A4 RID: 26532 RVA: 0x001F86E4 File Offset: 0x001F68E4
		// (set) Token: 0x060067A5 RID: 26533 RVA: 0x00038044 File Offset: 0x00036244
		public unsafe Sprite ii
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClockController.NativeFieldInfoPtr_ii);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClockController.NativeFieldInfoPtr_ii), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002388 RID: 9096
		// (get) Token: 0x060067A6 RID: 26534 RVA: 0x001F8714 File Offset: 0x001F6914
		// (set) Token: 0x060067A7 RID: 26535 RVA: 0x00038063 File Offset: 0x00036263
		public unsafe Sprite iii
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClockController.NativeFieldInfoPtr_iii);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClockController.NativeFieldInfoPtr_iii), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002389 RID: 9097
		// (get) Token: 0x060067A8 RID: 26536 RVA: 0x001F8744 File Offset: 0x001F6944
		// (set) Token: 0x060067A9 RID: 26537 RVA: 0x00038082 File Offset: 0x00036282
		public unsafe Sprite iv
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClockController.NativeFieldInfoPtr_iv);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClockController.NativeFieldInfoPtr_iv), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700238A RID: 9098
		// (get) Token: 0x060067AA RID: 26538 RVA: 0x001F8774 File Offset: 0x001F6974
		// (set) Token: 0x060067AB RID: 26539 RVA: 0x000380A1 File Offset: 0x000362A1
		public unsafe Sprite v
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClockController.NativeFieldInfoPtr_v);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClockController.NativeFieldInfoPtr_v), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700238B RID: 9099
		// (get) Token: 0x060067AC RID: 26540 RVA: 0x001F87A4 File Offset: 0x001F69A4
		// (set) Token: 0x060067AD RID: 26541 RVA: 0x000380C0 File Offset: 0x000362C0
		public unsafe Sprite vi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClockController.NativeFieldInfoPtr_vi);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClockController.NativeFieldInfoPtr_vi), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700238C RID: 9100
		// (get) Token: 0x060067AE RID: 26542 RVA: 0x001F87D4 File Offset: 0x001F69D4
		// (set) Token: 0x060067AF RID: 26543 RVA: 0x000380DF File Offset: 0x000362DF
		public unsafe Sprite vii
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClockController.NativeFieldInfoPtr_vii);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClockController.NativeFieldInfoPtr_vii), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700238D RID: 9101
		// (get) Token: 0x060067B0 RID: 26544 RVA: 0x001F8804 File Offset: 0x001F6A04
		// (set) Token: 0x060067B1 RID: 26545 RVA: 0x000380FE File Offset: 0x000362FE
		public unsafe Sprite viii
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClockController.NativeFieldInfoPtr_viii);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClockController.NativeFieldInfoPtr_viii), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700238E RID: 9102
		// (get) Token: 0x060067B2 RID: 26546 RVA: 0x001F8834 File Offset: 0x001F6A34
		// (set) Token: 0x060067B3 RID: 26547 RVA: 0x0003811D File Offset: 0x0003631D
		public unsafe Sprite ix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClockController.NativeFieldInfoPtr_ix);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClockController.NativeFieldInfoPtr_ix), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700238F RID: 9103
		// (get) Token: 0x060067B4 RID: 26548 RVA: 0x001F8864 File Offset: 0x001F6A64
		// (set) Token: 0x060067B5 RID: 26549 RVA: 0x0003813C File Offset: 0x0003633C
		public unsafe Sprite x
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClockController.NativeFieldInfoPtr_x);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClockController.NativeFieldInfoPtr_x), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002390 RID: 9104
		// (get) Token: 0x060067B6 RID: 26550 RVA: 0x001F8894 File Offset: 0x001F6A94
		// (set) Token: 0x060067B7 RID: 26551 RVA: 0x0003815B File Offset: 0x0003635B
		public unsafe Sprite xi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClockController.NativeFieldInfoPtr_xi);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClockController.NativeFieldInfoPtr_xi), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002391 RID: 9105
		// (get) Token: 0x060067B8 RID: 26552 RVA: 0x001F88C4 File Offset: 0x001F6AC4
		// (set) Token: 0x060067B9 RID: 26553 RVA: 0x0003817A File Offset: 0x0003637A
		public unsafe Image timeInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClockController.NativeFieldInfoPtr_timeInterval);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClockController.NativeFieldInfoPtr_timeInterval), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002392 RID: 9106
		// (get) Token: 0x060067BA RID: 26554 RVA: 0x001F88F4 File Offset: 0x001F6AF4
		// (set) Token: 0x060067BB RID: 26555 RVA: 0x00038199 File Offset: 0x00036399
		public unsafe Image minuteInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClockController.NativeFieldInfoPtr_minuteInterval);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClockController.NativeFieldInfoPtr_minuteInterval), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002393 RID: 9107
		// (get) Token: 0x060067BC RID: 26556 RVA: 0x001F8924 File Offset: 0x001F6B24
		// (set) Token: 0x060067BD RID: 26557 RVA: 0x000381B8 File Offset: 0x000363B8
		public unsafe Image needle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClockController.NativeFieldInfoPtr_needle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClockController.NativeFieldInfoPtr_needle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002394 RID: 9108
		// (get) Token: 0x060067BE RID: 26558 RVA: 0x001F8954 File Offset: 0x001F6B54
		// (set) Token: 0x060067BF RID: 26559 RVA: 0x000381D7 File Offset: 0x000363D7
		public unsafe AudioClip timeSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClockController.NativeFieldInfoPtr_timeSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClockController.NativeFieldInfoPtr_timeSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002395 RID: 9109
		// (get) Token: 0x060067C0 RID: 26560 RVA: 0x001F8984 File Offset: 0x001F6B84
		// (set) Token: 0x060067C1 RID: 26561 RVA: 0x000381F6 File Offset: 0x000363F6
		public unsafe byte currentClock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClockController.NativeFieldInfoPtr_currentClock);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClockController.NativeFieldInfoPtr_currentClock)) = value;
			}
		}

		// Token: 0x17002396 RID: 9110
		// (get) Token: 0x060067C2 RID: 26562 RVA: 0x001F89AC File Offset: 0x001F6BAC
		// (set) Token: 0x060067C3 RID: 26563 RVA: 0x00038211 File Offset: 0x00036411
		public unsafe byte startClock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClockController.NativeFieldInfoPtr_startClock);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClockController.NativeFieldInfoPtr_startClock)) = value;
			}
		}

		// Token: 0x17002397 RID: 9111
		// (get) Token: 0x060067C4 RID: 26564 RVA: 0x001F89D4 File Offset: 0x001F6BD4
		// (set) Token: 0x060067C5 RID: 26565 RVA: 0x0003822C File Offset: 0x0003642C
		public unsafe byte finishClock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClockController.NativeFieldInfoPtr_finishClock);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClockController.NativeFieldInfoPtr_finishClock)) = value;
			}
		}

		// Token: 0x040044B0 RID: 17584
		private static readonly IntPtr NativeFieldInfoPtr_xii;

		// Token: 0x040044B1 RID: 17585
		private static readonly IntPtr NativeFieldInfoPtr_i;

		// Token: 0x040044B2 RID: 17586
		private static readonly IntPtr NativeFieldInfoPtr_ii;

		// Token: 0x040044B3 RID: 17587
		private static readonly IntPtr NativeFieldInfoPtr_iii;

		// Token: 0x040044B4 RID: 17588
		private static readonly IntPtr NativeFieldInfoPtr_iv;

		// Token: 0x040044B5 RID: 17589
		private static readonly IntPtr NativeFieldInfoPtr_v;

		// Token: 0x040044B6 RID: 17590
		private static readonly IntPtr NativeFieldInfoPtr_vi;

		// Token: 0x040044B7 RID: 17591
		private static readonly IntPtr NativeFieldInfoPtr_vii;

		// Token: 0x040044B8 RID: 17592
		private static readonly IntPtr NativeFieldInfoPtr_viii;

		// Token: 0x040044B9 RID: 17593
		private static readonly IntPtr NativeFieldInfoPtr_ix;

		// Token: 0x040044BA RID: 17594
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x040044BB RID: 17595
		private static readonly IntPtr NativeFieldInfoPtr_xi;

		// Token: 0x040044BC RID: 17596
		private static readonly IntPtr NativeFieldInfoPtr_timeInterval;

		// Token: 0x040044BD RID: 17597
		private static readonly IntPtr NativeFieldInfoPtr_minuteInterval;

		// Token: 0x040044BE RID: 17598
		private static readonly IntPtr NativeFieldInfoPtr_needle;

		// Token: 0x040044BF RID: 17599
		private static readonly IntPtr NativeFieldInfoPtr_timeSFX;

		// Token: 0x040044C0 RID: 17600
		private static readonly IntPtr NativeFieldInfoPtr_currentClock;

		// Token: 0x040044C1 RID: 17601
		private static readonly IntPtr NativeFieldInfoPtr_startClock;

		// Token: 0x040044C2 RID: 17602
		private static readonly IntPtr NativeFieldInfoPtr_finishClock;

		// Token: 0x040044C3 RID: 17603
		private static readonly IntPtr NativeMethodInfoPtr_set_Needle_Private_set_Void_Sprite_0;

		// Token: 0x040044C4 RID: 17604
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040044C5 RID: 17605
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Byte_Byte_0;

		// Token: 0x040044C6 RID: 17606
		private static readonly IntPtr NativeMethodInfoPtr_SetNeedle_Private_Void_Byte_0;

		// Token: 0x040044C7 RID: 17607
		private static readonly IntPtr NativeMethodInfoPtr_SetProgress_Public_Void_Single_0;

		// Token: 0x040044C8 RID: 17608
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x040044C9 RID: 17609
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
