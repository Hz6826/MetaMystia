using System;
using Common.Audio;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x0200008C RID: 140
	[Serializable]
	public class SpellFire : PatchouliSpellBase
	{
		// Token: 0x06000D99 RID: 3481 RVA: 0x000CBBBC File Offset: 0x000C9DBC
		// Note: this type is marked as 'beforefieldinit'.
		static SpellFire()
		{
			Il2CppClassPointerStore<SpellFire>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.BossBattle.DLC4_BossBattle", "SpellFire");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellFire>.NativeClassPtr);
			SpellFire.NativeFieldInfoPtr_damagePercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellFire>.NativeClassPtr, "damagePercentage");
			SpellFire.NativeFieldInfoPtr_amplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellFire>.NativeClassPtr, "amplitude");
			SpellFire.NativeFieldInfoPtr_shakeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellFire>.NativeClassPtr, "shakeDuration");
			SpellFire.NativeFieldInfoPtr_fadeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellFire>.NativeClassPtr, "fadeTime");
			SpellFire.NativeFieldInfoPtr_fireballNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellFire>.NativeClassPtr, "fireballNum");
			SpellFire.NativeFieldInfoPtr_fireBallVfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellFire>.NativeClassPtr, "fireBallVfx");
			SpellFire.NativeFieldInfoPtr_fireBombVFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellFire>.NativeClassPtr, "fireBombVFX");
			SpellFire.NativeFieldInfoPtr_wholeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellFire>.NativeClassPtr, "wholeDuration");
			SpellFire.NativeFieldInfoPtr_fireBallInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellFire>.NativeClassPtr, "fireBallInterval");
			SpellFire.NativeFieldInfoPtr_fireBallSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellFire>.NativeClassPtr, "fireBallSfx");
			SpellFire.NativeMethodInfoPtr_DescriptionMethodB_Public_Virtual_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellFire>.NativeClassPtr, 100665571);
			SpellFire.NativeMethodInfoPtr_DescriptionMethodD_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellFire>.NativeClassPtr, 100665572);
			SpellFire.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellFire>.NativeClassPtr, 100665573);
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x000CBCF0 File Offset: 0x000C9EF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44232, XrefRangeEnd = 44234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string DescriptionMethodB(string a, int _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(a);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpellFire.NativeMethodInfoPtr_DescriptionMethodB_Public_Virtual_String_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000D9B RID: 3483 RVA: 0x000CBD54 File Offset: 0x000C9F54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44234, XrefRangeEnd = 44239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string DescriptionMethodD(string oldText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(oldText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpellFire.NativeMethodInfoPtr_DescriptionMethodD_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000D9C RID: 3484 RVA: 0x000CBDA8 File Offset: 0x000C9FA8
		[CallerCount(2138)]
		[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpellFire() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellFire>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellFire.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D9D RID: 3485 RVA: 0x0000914B File Offset: 0x0000734B
		public SpellFire(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06000D9E RID: 3486 RVA: 0x000CBDE4 File Offset: 0x000C9FE4
		// (set) Token: 0x06000D9F RID: 3487 RVA: 0x00009154 File Offset: 0x00007354
		public unsafe float damagePercentage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellFire.NativeFieldInfoPtr_damagePercentage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellFire.NativeFieldInfoPtr_damagePercentage)) = value;
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06000DA0 RID: 3488 RVA: 0x000CBE0C File Offset: 0x000CA00C
		// (set) Token: 0x06000DA1 RID: 3489 RVA: 0x0000916F File Offset: 0x0000736F
		public unsafe float amplitude
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellFire.NativeFieldInfoPtr_amplitude);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellFire.NativeFieldInfoPtr_amplitude)) = value;
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06000DA2 RID: 3490 RVA: 0x000CBE34 File Offset: 0x000CA034
		// (set) Token: 0x06000DA3 RID: 3491 RVA: 0x0000918A File Offset: 0x0000738A
		public unsafe float shakeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellFire.NativeFieldInfoPtr_shakeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellFire.NativeFieldInfoPtr_shakeDuration)) = value;
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06000DA4 RID: 3492 RVA: 0x000CBE5C File Offset: 0x000CA05C
		// (set) Token: 0x06000DA5 RID: 3493 RVA: 0x000091A5 File Offset: 0x000073A5
		public unsafe float fadeTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellFire.NativeFieldInfoPtr_fadeTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellFire.NativeFieldInfoPtr_fadeTime)) = value;
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06000DA6 RID: 3494 RVA: 0x000CBE84 File Offset: 0x000CA084
		// (set) Token: 0x06000DA7 RID: 3495 RVA: 0x000091C0 File Offset: 0x000073C0
		public unsafe int fireballNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellFire.NativeFieldInfoPtr_fireballNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellFire.NativeFieldInfoPtr_fireballNum)) = value;
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06000DA8 RID: 3496 RVA: 0x000CBEAC File Offset: 0x000CA0AC
		// (set) Token: 0x06000DA9 RID: 3497 RVA: 0x000091DB File Offset: 0x000073DB
		public VFXPrefab fireBallVfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellFire.NativeFieldInfoPtr_fireBallVfx);
				return new VFXPrefab(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VFXPrefab>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellFire.NativeFieldInfoPtr_fireBallVfx), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<VFXPrefab>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06000DAA RID: 3498 RVA: 0x000CBEDC File Offset: 0x000CA0DC
		// (set) Token: 0x06000DAB RID: 3499 RVA: 0x00009209 File Offset: 0x00007409
		public VFXPrefab fireBombVFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellFire.NativeFieldInfoPtr_fireBombVFX);
				return new VFXPrefab(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VFXPrefab>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellFire.NativeFieldInfoPtr_fireBombVFX), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<VFXPrefab>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06000DAC RID: 3500 RVA: 0x000CBF0C File Offset: 0x000CA10C
		// (set) Token: 0x06000DAD RID: 3501 RVA: 0x00009237 File Offset: 0x00007437
		public unsafe float wholeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellFire.NativeFieldInfoPtr_wholeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellFire.NativeFieldInfoPtr_wholeDuration)) = value;
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06000DAE RID: 3502 RVA: 0x000CBF34 File Offset: 0x000CA134
		// (set) Token: 0x06000DAF RID: 3503 RVA: 0x00009252 File Offset: 0x00007452
		public unsafe float fireBallInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellFire.NativeFieldInfoPtr_fireBallInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellFire.NativeFieldInfoPtr_fireBallInterval)) = value;
			}
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06000DB0 RID: 3504 RVA: 0x000CBF5C File Offset: 0x000CA15C
		// (set) Token: 0x06000DB1 RID: 3505 RVA: 0x0000926D File Offset: 0x0000746D
		public GlobalAudioManager.DelayAudioClip fireBallSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellFire.NativeFieldInfoPtr_fireBallSfx);
				return new GlobalAudioManager.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalAudioManager.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellFire.NativeFieldInfoPtr_fireBallSfx), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalAudioManager.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x0400093A RID: 2362
		private static readonly IntPtr NativeFieldInfoPtr_damagePercentage;

		// Token: 0x0400093B RID: 2363
		private static readonly IntPtr NativeFieldInfoPtr_amplitude;

		// Token: 0x0400093C RID: 2364
		private static readonly IntPtr NativeFieldInfoPtr_shakeDuration;

		// Token: 0x0400093D RID: 2365
		private static readonly IntPtr NativeFieldInfoPtr_fadeTime;

		// Token: 0x0400093E RID: 2366
		private static readonly IntPtr NativeFieldInfoPtr_fireballNum;

		// Token: 0x0400093F RID: 2367
		private static readonly IntPtr NativeFieldInfoPtr_fireBallVfx;

		// Token: 0x04000940 RID: 2368
		private static readonly IntPtr NativeFieldInfoPtr_fireBombVFX;

		// Token: 0x04000941 RID: 2369
		private static readonly IntPtr NativeFieldInfoPtr_wholeDuration;

		// Token: 0x04000942 RID: 2370
		private static readonly IntPtr NativeFieldInfoPtr_fireBallInterval;

		// Token: 0x04000943 RID: 2371
		private static readonly IntPtr NativeFieldInfoPtr_fireBallSfx;

		// Token: 0x04000944 RID: 2372
		private static readonly IntPtr NativeMethodInfoPtr_DescriptionMethodB_Public_Virtual_String_String_Int32_0;

		// Token: 0x04000945 RID: 2373
		private static readonly IntPtr NativeMethodInfoPtr_DescriptionMethodD_Public_Virtual_String_String_0;

		// Token: 0x04000946 RID: 2374
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
