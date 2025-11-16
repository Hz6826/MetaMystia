using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace NightScene.UI.HUDUtility
{
	// Token: 0x020001C0 RID: 448
	public class ComboController : MonoBehaviour
	{
		// Token: 0x060037C9 RID: 14281 RVA: 0x0015DDEC File Offset: 0x0015BFEC
		// Note: this type is marked as 'beforefieldinit'.
		static ComboController()
		{
			Il2CppClassPointerStore<ComboController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.UI.HUDUtility", "ComboController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComboController>.NativeClassPtr);
			ComboController.NativeFieldInfoPtr_i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComboController>.NativeClassPtr, "i");
			ComboController.NativeFieldInfoPtr_ii = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComboController>.NativeClassPtr, "ii");
			ComboController.NativeFieldInfoPtr_iii = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComboController>.NativeClassPtr, "iii");
			ComboController.NativeFieldInfoPtr_iv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComboController>.NativeClassPtr, "iv");
			ComboController.NativeFieldInfoPtr_v = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComboController>.NativeClassPtr, "v");
			ComboController.NativeFieldInfoPtr_vi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComboController>.NativeClassPtr, "vi");
			ComboController.NativeFieldInfoPtr_vii = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComboController>.NativeClassPtr, "vii");
			ComboController.NativeFieldInfoPtr_viii = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComboController>.NativeClassPtr, "viii");
			ComboController.NativeFieldInfoPtr_ix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComboController>.NativeClassPtr, "ix");
			ComboController.NativeFieldInfoPtr_o = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComboController>.NativeClassPtr, "o");
			ComboController.NativeFieldInfoPtr_hundredth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComboController>.NativeClassPtr, "hundredth");
			ComboController.NativeFieldInfoPtr_tens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComboController>.NativeClassPtr, "tens");
			ComboController.NativeFieldInfoPtr_unit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComboController>.NativeClassPtr, "unit");
			ComboController.NativeFieldInfoPtr_illumination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComboController>.NativeClassPtr, "illumination");
			ComboController.NativeFieldInfoPtr_onDeductingComboColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComboController>.NativeClassPtr, "onDeductingComboColor");
			ComboController.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComboController>.NativeClassPtr, "current");
			ComboController.NativeFieldInfoPtr__ReverseAdd_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComboController>.NativeClassPtr, "<ReverseAdd>k__BackingField");
			ComboController.NativeMethodInfoPtr_get_ReverseAdd_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComboController>.NativeClassPtr, 100673862);
			ComboController.NativeMethodInfoPtr_set_ReverseAdd_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComboController>.NativeClassPtr, 100673863);
			ComboController.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComboController>.NativeClassPtr, 100673864);
			ComboController.NativeMethodInfoPtr_SetCombo_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComboController>.NativeClassPtr, 100673865);
			ComboController.NativeMethodInfoPtr_OnComboIlluminationUpdating_Private_IEnumerator_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComboController>.NativeClassPtr, 100673866);
			ComboController.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComboController>.NativeClassPtr, 100673867);
			ComboController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComboController>.NativeClassPtr, 100673868);
			ComboController.NativeMethodInfoPtr_Method_Private_Sprite_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComboController>.NativeClassPtr, 100673869);
		}

		// Token: 0x17001349 RID: 4937
		// (get) Token: 0x060037CA RID: 14282 RVA: 0x0015E010 File Offset: 0x0015C210
		// (set) Token: 0x060037CB RID: 14283 RVA: 0x0015E04C File Offset: 0x0015C24C
		public unsafe bool ReverseAdd
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129956, RefRangeEnd = 129957, XrefRangeStart = 129956, XrefRangeEnd = 129956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComboController.NativeMethodInfoPtr_get_ReverseAdd_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComboController.NativeMethodInfoPtr_set_ReverseAdd_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037CC RID: 14284 RVA: 0x0015E08C File Offset: 0x0015C28C
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComboController.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037CD RID: 14285 RVA: 0x0015E0C0 File Offset: 0x0015C2C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 129972, RefRangeEnd = 129973, XrefRangeStart = 129957, XrefRangeEnd = 129972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCombo(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComboController.NativeMethodInfoPtr_SetCombo_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037CE RID: 14286 RVA: 0x0015E100 File Offset: 0x0015C300
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 129978, RefRangeEnd = 129979, XrefRangeStart = 129973, XrefRangeEnd = 129978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator OnComboIlluminationUpdating(float fadeSpeed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fadeSpeed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComboController.NativeMethodInfoPtr_OnComboIlluminationUpdating_Private_IEnumerator_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060037CF RID: 14287 RVA: 0x0015E14C File Offset: 0x0015C34C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129979, XrefRangeEnd = 129993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ComboController.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037D0 RID: 14288 RVA: 0x0015E188 File Offset: 0x0015C388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129993, XrefRangeEnd = 129994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ComboController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComboController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComboController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037D1 RID: 14289 RVA: 0x0015E1C4 File Offset: 0x0015C3C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 129994, RefRangeEnd = 129997, XrefRangeStart = 129994, XrefRangeEnd = 129994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sprite Method_Private_Sprite_Int32_0(int digit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref digit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComboController.NativeMethodInfoPtr_Method_Private_Sprite_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
		}

		// Token: 0x060037D2 RID: 14290 RVA: 0x0001F16F File Offset: 0x0001D36F
		public ComboController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001338 RID: 4920
		// (get) Token: 0x060037D3 RID: 14291 RVA: 0x0015E210 File Offset: 0x0015C410
		// (set) Token: 0x060037D4 RID: 14292 RVA: 0x0001F178 File Offset: 0x0001D378
		public unsafe Sprite i
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComboController.NativeFieldInfoPtr_i);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComboController.NativeFieldInfoPtr_i), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001339 RID: 4921
		// (get) Token: 0x060037D5 RID: 14293 RVA: 0x0015E240 File Offset: 0x0015C440
		// (set) Token: 0x060037D6 RID: 14294 RVA: 0x0001F197 File Offset: 0x0001D397
		public unsafe Sprite ii
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComboController.NativeFieldInfoPtr_ii);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComboController.NativeFieldInfoPtr_ii), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700133A RID: 4922
		// (get) Token: 0x060037D7 RID: 14295 RVA: 0x0015E270 File Offset: 0x0015C470
		// (set) Token: 0x060037D8 RID: 14296 RVA: 0x0001F1B6 File Offset: 0x0001D3B6
		public unsafe Sprite iii
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComboController.NativeFieldInfoPtr_iii);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComboController.NativeFieldInfoPtr_iii), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700133B RID: 4923
		// (get) Token: 0x060037D9 RID: 14297 RVA: 0x0015E2A0 File Offset: 0x0015C4A0
		// (set) Token: 0x060037DA RID: 14298 RVA: 0x0001F1D5 File Offset: 0x0001D3D5
		public unsafe Sprite iv
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComboController.NativeFieldInfoPtr_iv);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComboController.NativeFieldInfoPtr_iv), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700133C RID: 4924
		// (get) Token: 0x060037DB RID: 14299 RVA: 0x0015E2D0 File Offset: 0x0015C4D0
		// (set) Token: 0x060037DC RID: 14300 RVA: 0x0001F1F4 File Offset: 0x0001D3F4
		public unsafe Sprite v
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComboController.NativeFieldInfoPtr_v);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComboController.NativeFieldInfoPtr_v), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700133D RID: 4925
		// (get) Token: 0x060037DD RID: 14301 RVA: 0x0015E300 File Offset: 0x0015C500
		// (set) Token: 0x060037DE RID: 14302 RVA: 0x0001F213 File Offset: 0x0001D413
		public unsafe Sprite vi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComboController.NativeFieldInfoPtr_vi);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComboController.NativeFieldInfoPtr_vi), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700133E RID: 4926
		// (get) Token: 0x060037DF RID: 14303 RVA: 0x0015E330 File Offset: 0x0015C530
		// (set) Token: 0x060037E0 RID: 14304 RVA: 0x0001F232 File Offset: 0x0001D432
		public unsafe Sprite vii
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComboController.NativeFieldInfoPtr_vii);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComboController.NativeFieldInfoPtr_vii), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700133F RID: 4927
		// (get) Token: 0x060037E1 RID: 14305 RVA: 0x0015E360 File Offset: 0x0015C560
		// (set) Token: 0x060037E2 RID: 14306 RVA: 0x0001F251 File Offset: 0x0001D451
		public unsafe Sprite viii
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComboController.NativeFieldInfoPtr_viii);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComboController.NativeFieldInfoPtr_viii), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001340 RID: 4928
		// (get) Token: 0x060037E3 RID: 14307 RVA: 0x0015E390 File Offset: 0x0015C590
		// (set) Token: 0x060037E4 RID: 14308 RVA: 0x0001F270 File Offset: 0x0001D470
		public unsafe Sprite ix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComboController.NativeFieldInfoPtr_ix);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComboController.NativeFieldInfoPtr_ix), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001341 RID: 4929
		// (get) Token: 0x060037E5 RID: 14309 RVA: 0x0015E3C0 File Offset: 0x0015C5C0
		// (set) Token: 0x060037E6 RID: 14310 RVA: 0x0001F28F File Offset: 0x0001D48F
		public unsafe Sprite o
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComboController.NativeFieldInfoPtr_o);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComboController.NativeFieldInfoPtr_o), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001342 RID: 4930
		// (get) Token: 0x060037E7 RID: 14311 RVA: 0x0015E3F0 File Offset: 0x0015C5F0
		// (set) Token: 0x060037E8 RID: 14312 RVA: 0x0001F2AE File Offset: 0x0001D4AE
		public unsafe Image hundredth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComboController.NativeFieldInfoPtr_hundredth);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComboController.NativeFieldInfoPtr_hundredth), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001343 RID: 4931
		// (get) Token: 0x060037E9 RID: 14313 RVA: 0x0015E420 File Offset: 0x0015C620
		// (set) Token: 0x060037EA RID: 14314 RVA: 0x0001F2CD File Offset: 0x0001D4CD
		public unsafe Image tens
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComboController.NativeFieldInfoPtr_tens);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComboController.NativeFieldInfoPtr_tens), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001344 RID: 4932
		// (get) Token: 0x060037EB RID: 14315 RVA: 0x0015E450 File Offset: 0x0015C650
		// (set) Token: 0x060037EC RID: 14316 RVA: 0x0001F2EC File Offset: 0x0001D4EC
		public unsafe Image unit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComboController.NativeFieldInfoPtr_unit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComboController.NativeFieldInfoPtr_unit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001345 RID: 4933
		// (get) Token: 0x060037ED RID: 14317 RVA: 0x0015E480 File Offset: 0x0015C680
		// (set) Token: 0x060037EE RID: 14318 RVA: 0x0001F30B File Offset: 0x0001D50B
		public unsafe Image illumination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComboController.NativeFieldInfoPtr_illumination);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComboController.NativeFieldInfoPtr_illumination), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001346 RID: 4934
		// (get) Token: 0x060037EF RID: 14319 RVA: 0x0015E4B0 File Offset: 0x0015C6B0
		// (set) Token: 0x060037F0 RID: 14320 RVA: 0x0001F32A File Offset: 0x0001D52A
		public unsafe Color onDeductingComboColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComboController.NativeFieldInfoPtr_onDeductingComboColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComboController.NativeFieldInfoPtr_onDeductingComboColor)) = value;
			}
		}

		// Token: 0x17001347 RID: 4935
		// (get) Token: 0x060037F1 RID: 14321 RVA: 0x0015E4D8 File Offset: 0x0015C6D8
		// (set) Token: 0x060037F2 RID: 14322 RVA: 0x0001F345 File Offset: 0x0001D545
		public unsafe int current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComboController.NativeFieldInfoPtr_current);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComboController.NativeFieldInfoPtr_current)) = value;
			}
		}

		// Token: 0x17001348 RID: 4936
		// (get) Token: 0x060037F3 RID: 14323 RVA: 0x0015E500 File Offset: 0x0015C700
		// (set) Token: 0x060037F4 RID: 14324 RVA: 0x0001F360 File Offset: 0x0001D560
		public unsafe bool _ReverseAdd_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComboController.NativeFieldInfoPtr__ReverseAdd_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComboController.NativeFieldInfoPtr__ReverseAdd_k__BackingField)) = value;
			}
		}

		// Token: 0x040025A5 RID: 9637
		private static readonly IntPtr NativeFieldInfoPtr_i;

		// Token: 0x040025A6 RID: 9638
		private static readonly IntPtr NativeFieldInfoPtr_ii;

		// Token: 0x040025A7 RID: 9639
		private static readonly IntPtr NativeFieldInfoPtr_iii;

		// Token: 0x040025A8 RID: 9640
		private static readonly IntPtr NativeFieldInfoPtr_iv;

		// Token: 0x040025A9 RID: 9641
		private static readonly IntPtr NativeFieldInfoPtr_v;

		// Token: 0x040025AA RID: 9642
		private static readonly IntPtr NativeFieldInfoPtr_vi;

		// Token: 0x040025AB RID: 9643
		private static readonly IntPtr NativeFieldInfoPtr_vii;

		// Token: 0x040025AC RID: 9644
		private static readonly IntPtr NativeFieldInfoPtr_viii;

		// Token: 0x040025AD RID: 9645
		private static readonly IntPtr NativeFieldInfoPtr_ix;

		// Token: 0x040025AE RID: 9646
		private static readonly IntPtr NativeFieldInfoPtr_o;

		// Token: 0x040025AF RID: 9647
		private static readonly IntPtr NativeFieldInfoPtr_hundredth;

		// Token: 0x040025B0 RID: 9648
		private static readonly IntPtr NativeFieldInfoPtr_tens;

		// Token: 0x040025B1 RID: 9649
		private static readonly IntPtr NativeFieldInfoPtr_unit;

		// Token: 0x040025B2 RID: 9650
		private static readonly IntPtr NativeFieldInfoPtr_illumination;

		// Token: 0x040025B3 RID: 9651
		private static readonly IntPtr NativeFieldInfoPtr_onDeductingComboColor;

		// Token: 0x040025B4 RID: 9652
		private static readonly IntPtr NativeFieldInfoPtr_current;

		// Token: 0x040025B5 RID: 9653
		private static readonly IntPtr NativeFieldInfoPtr__ReverseAdd_k__BackingField;

		// Token: 0x040025B6 RID: 9654
		private static readonly IntPtr NativeMethodInfoPtr_get_ReverseAdd_Public_get_Boolean_0;

		// Token: 0x040025B7 RID: 9655
		private static readonly IntPtr NativeMethodInfoPtr_set_ReverseAdd_Public_set_Void_Boolean_0;

		// Token: 0x040025B8 RID: 9656
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040025B9 RID: 9657
		private static readonly IntPtr NativeMethodInfoPtr_SetCombo_Public_Void_Int32_0;

		// Token: 0x040025BA RID: 9658
		private static readonly IntPtr NativeMethodInfoPtr_OnComboIlluminationUpdating_Private_IEnumerator_Single_0;

		// Token: 0x040025BB RID: 9659
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x040025BC RID: 9660
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040025BD RID: 9661
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Sprite_Int32_0;

		// Token: 0x0200093A RID: 2362
		[ObfuscatedName("NightScene.UI.HUDUtility.ComboController+<OnComboIlluminationUpdating>d__22")]
		public sealed class _OnComboIlluminationUpdating_d__22 : Il2CppSystem.Object
		{
			// Token: 0x0600B97F RID: 47487 RVA: 0x002ED524 File Offset: 0x002EB724
			// Note: this type is marked as 'beforefieldinit'.
			static _OnComboIlluminationUpdating_d__22()
			{
				Il2CppClassPointerStore<ComboController._OnComboIlluminationUpdating_d__22>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ComboController>.NativeClassPtr, "<OnComboIlluminationUpdating>d__22");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComboController._OnComboIlluminationUpdating_d__22>.NativeClassPtr);
				ComboController._OnComboIlluminationUpdating_d__22.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComboController._OnComboIlluminationUpdating_d__22>.NativeClassPtr, "<>1__state");
				ComboController._OnComboIlluminationUpdating_d__22.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComboController._OnComboIlluminationUpdating_d__22>.NativeClassPtr, "<>2__current");
				ComboController._OnComboIlluminationUpdating_d__22.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComboController._OnComboIlluminationUpdating_d__22>.NativeClassPtr, "<>4__this");
				ComboController._OnComboIlluminationUpdating_d__22.NativeFieldInfoPtr_fadeSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComboController._OnComboIlluminationUpdating_d__22>.NativeClassPtr, "fadeSpeed");
				ComboController._OnComboIlluminationUpdating_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComboController._OnComboIlluminationUpdating_d__22>.NativeClassPtr, 100673870);
				ComboController._OnComboIlluminationUpdating_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComboController._OnComboIlluminationUpdating_d__22>.NativeClassPtr, 100673871);
				ComboController._OnComboIlluminationUpdating_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComboController._OnComboIlluminationUpdating_d__22>.NativeClassPtr, 100673872);
				ComboController._OnComboIlluminationUpdating_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComboController._OnComboIlluminationUpdating_d__22>.NativeClassPtr, 100673873);
				ComboController._OnComboIlluminationUpdating_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComboController._OnComboIlluminationUpdating_d__22>.NativeClassPtr, 100673874);
				ComboController._OnComboIlluminationUpdating_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComboController._OnComboIlluminationUpdating_d__22>.NativeClassPtr, 100673875);
			}

			// Token: 0x0600B980 RID: 47488 RVA: 0x002ED618 File Offset: 0x002EB818
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnComboIlluminationUpdating_d__22(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComboController._OnComboIlluminationUpdating_d__22>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComboController._OnComboIlluminationUpdating_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B981 RID: 47489 RVA: 0x002ED660 File Offset: 0x002EB860
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComboController._OnComboIlluminationUpdating_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B982 RID: 47490 RVA: 0x002ED694 File Offset: 0x002EB894
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129948, XrefRangeEnd = 129950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComboController._OnComboIlluminationUpdating_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003CC7 RID: 15559
			// (get) Token: 0x0600B983 RID: 47491 RVA: 0x002ED6D0 File Offset: 0x002EB8D0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComboController._OnComboIlluminationUpdating_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600B984 RID: 47492 RVA: 0x002ED710 File Offset: 0x002EB910
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129950, XrefRangeEnd = 129956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComboController._OnComboIlluminationUpdating_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003CC8 RID: 15560
			// (get) Token: 0x0600B985 RID: 47493 RVA: 0x002ED744 File Offset: 0x002EB944
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComboController._OnComboIlluminationUpdating_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600B986 RID: 47494 RVA: 0x00064245 File Offset: 0x00062445
			public _OnComboIlluminationUpdating_d__22(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003CC3 RID: 15555
			// (get) Token: 0x0600B987 RID: 47495 RVA: 0x002ED784 File Offset: 0x002EB984
			// (set) Token: 0x0600B988 RID: 47496 RVA: 0x0006424E File Offset: 0x0006244E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComboController._OnComboIlluminationUpdating_d__22.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComboController._OnComboIlluminationUpdating_d__22.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003CC4 RID: 15556
			// (get) Token: 0x0600B989 RID: 47497 RVA: 0x002ED7AC File Offset: 0x002EB9AC
			// (set) Token: 0x0600B98A RID: 47498 RVA: 0x00064269 File Offset: 0x00062469
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComboController._OnComboIlluminationUpdating_d__22.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComboController._OnComboIlluminationUpdating_d__22.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CC5 RID: 15557
			// (get) Token: 0x0600B98B RID: 47499 RVA: 0x002ED7DC File Offset: 0x002EB9DC
			// (set) Token: 0x0600B98C RID: 47500 RVA: 0x00064288 File Offset: 0x00062488
			public unsafe ComboController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComboController._OnComboIlluminationUpdating_d__22.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ComboController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComboController._OnComboIlluminationUpdating_d__22.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CC6 RID: 15558
			// (get) Token: 0x0600B98D RID: 47501 RVA: 0x002ED80C File Offset: 0x002EBA0C
			// (set) Token: 0x0600B98E RID: 47502 RVA: 0x000642A7 File Offset: 0x000624A7
			public unsafe float fadeSpeed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComboController._OnComboIlluminationUpdating_d__22.NativeFieldInfoPtr_fadeSpeed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComboController._OnComboIlluminationUpdating_d__22.NativeFieldInfoPtr_fadeSpeed)) = value;
				}
			}

			// Token: 0x040077DF RID: 30687
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040077E0 RID: 30688
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040077E1 RID: 30689
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040077E2 RID: 30690
			private static readonly IntPtr NativeFieldInfoPtr_fadeSpeed;

			// Token: 0x040077E3 RID: 30691
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040077E4 RID: 30692
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040077E5 RID: 30693
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040077E6 RID: 30694
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040077E7 RID: 30695
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040077E8 RID: 30696
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
