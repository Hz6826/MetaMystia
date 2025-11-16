using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000292 RID: 658
	public class Spell_Youmu : SpellBase
	{
		// Token: 0x0600535F RID: 21343 RVA: 0x001B8934 File Offset: 0x001B6B34
		// Note: this type is marked as 'beforefieldinit'.
		static Spell_Youmu()
		{
			Il2CppClassPointerStore<Spell_Youmu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility.SkillCollection", "Spell_Youmu");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Youmu>.NativeClassPtr);
			Spell_Youmu.NativeFieldInfoPtr_postiveDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Youmu>.NativeClassPtr, "postiveDuration");
			Spell_Youmu.NativeFieldInfoPtr_cuttingboardMultiper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Youmu>.NativeClassPtr, "cuttingboardMultiper");
			Spell_Youmu.NativeFieldInfoPtr_negativeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Youmu>.NativeClassPtr, "negativeDuration");
			Spell_Youmu.NativeFieldInfoPtr_passionDecreasePertime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Youmu>.NativeClassPtr, "passionDecreasePertime");
			Spell_Youmu.NativeFieldInfoPtr_passionDecreaseUnitTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Youmu>.NativeClassPtr, "passionDecreaseUnitTime");
			Spell_Youmu.NativeFieldInfoPtr_patientEditMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Youmu>.NativeClassPtr, "patientEditMultiplier");
			Spell_Youmu.NativeFieldInfoPtr_youmuRewardVFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Youmu>.NativeClassPtr, "youmuRewardVFX");
			Spell_Youmu.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Youmu>.NativeClassPtr, 100680261);
			Spell_Youmu.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Youmu>.NativeClassPtr, 100680262);
			Spell_Youmu.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Youmu>.NativeClassPtr, 100680263);
			Spell_Youmu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Youmu>.NativeClassPtr, 100680264);
			Spell_Youmu.NativeMethodInfoPtr_Method_Internal_Static_String_Int32_String_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Youmu>.NativeClassPtr, 100680265);
			Spell_Youmu.NativeMethodInfoPtr__OnPositiveBuffExecute_b__9_1_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Youmu>.NativeClassPtr, 100680266);
		}

		// Token: 0x06005360 RID: 21344 RVA: 0x001B8A68 File Offset: 0x001B6C68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208375, XrefRangeEnd = 208377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OnGettingSpellOwnerIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Youmu.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005361 RID: 21345 RVA: 0x001B8AAC File Offset: 0x001B6CAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208377, XrefRangeEnd = 208382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Youmu.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06005362 RID: 21346 RVA: 0x001B8B08 File Offset: 0x001B6D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208382, XrefRangeEnd = 208387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Youmu.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06005363 RID: 21347 RVA: 0x001B8B64 File Offset: 0x001B6D64
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spell_Youmu() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Youmu>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Youmu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005364 RID: 21348 RVA: 0x001B8BA0 File Offset: 0x001B6DA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208387, XrefRangeEnd = 208391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Method_Internal_Static_String_Int32_String_PDM_0(int currentTime, string buffDescription)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref currentTime;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(buffDescription);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Youmu.NativeMethodInfoPtr_Method_Internal_Static_String_Int32_String_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005365 RID: 21349 RVA: 0x001B8BEC File Offset: 0x001B6DEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208391, XrefRangeEnd = 208402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPositiveBuffExecute_b__9_1(int x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Youmu.NativeMethodInfoPtr__OnPositiveBuffExecute_b__9_1_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005366 RID: 21350 RVA: 0x0002CC7F File Offset: 0x0002AE7F
		public Spell_Youmu(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C8F RID: 7311
		// (get) Token: 0x06005367 RID: 21351 RVA: 0x001B8C2C File Offset: 0x001B6E2C
		// (set) Token: 0x06005368 RID: 21352 RVA: 0x0002CC88 File Offset: 0x0002AE88
		public unsafe int postiveDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Youmu.NativeFieldInfoPtr_postiveDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Youmu.NativeFieldInfoPtr_postiveDuration)) = value;
			}
		}

		// Token: 0x17001C90 RID: 7312
		// (get) Token: 0x06005369 RID: 21353 RVA: 0x001B8C54 File Offset: 0x001B6E54
		// (set) Token: 0x0600536A RID: 21354 RVA: 0x0002CCA3 File Offset: 0x0002AEA3
		public unsafe float cuttingboardMultiper
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Youmu.NativeFieldInfoPtr_cuttingboardMultiper);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Youmu.NativeFieldInfoPtr_cuttingboardMultiper)) = value;
			}
		}

		// Token: 0x17001C91 RID: 7313
		// (get) Token: 0x0600536B RID: 21355 RVA: 0x001B8C7C File Offset: 0x001B6E7C
		// (set) Token: 0x0600536C RID: 21356 RVA: 0x0002CCBE File Offset: 0x0002AEBE
		public unsafe int negativeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Youmu.NativeFieldInfoPtr_negativeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Youmu.NativeFieldInfoPtr_negativeDuration)) = value;
			}
		}

		// Token: 0x17001C92 RID: 7314
		// (get) Token: 0x0600536D RID: 21357 RVA: 0x001B8CA4 File Offset: 0x001B6EA4
		// (set) Token: 0x0600536E RID: 21358 RVA: 0x0002CCD9 File Offset: 0x0002AED9
		public unsafe int passionDecreasePertime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Youmu.NativeFieldInfoPtr_passionDecreasePertime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Youmu.NativeFieldInfoPtr_passionDecreasePertime)) = value;
			}
		}

		// Token: 0x17001C93 RID: 7315
		// (get) Token: 0x0600536F RID: 21359 RVA: 0x001B8CCC File Offset: 0x001B6ECC
		// (set) Token: 0x06005370 RID: 21360 RVA: 0x0002CCF4 File Offset: 0x0002AEF4
		public unsafe float passionDecreaseUnitTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Youmu.NativeFieldInfoPtr_passionDecreaseUnitTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Youmu.NativeFieldInfoPtr_passionDecreaseUnitTime)) = value;
			}
		}

		// Token: 0x17001C94 RID: 7316
		// (get) Token: 0x06005371 RID: 21361 RVA: 0x001B8CF4 File Offset: 0x001B6EF4
		// (set) Token: 0x06005372 RID: 21362 RVA: 0x0002CD0F File Offset: 0x0002AF0F
		public unsafe float patientEditMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Youmu.NativeFieldInfoPtr_patientEditMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Youmu.NativeFieldInfoPtr_patientEditMultiplier)) = value;
			}
		}

		// Token: 0x17001C95 RID: 7317
		// (get) Token: 0x06005373 RID: 21363 RVA: 0x001B8D1C File Offset: 0x001B6F1C
		// (set) Token: 0x06005374 RID: 21364 RVA: 0x0002CD2A File Offset: 0x0002AF2A
		public unsafe GameObject youmuRewardVFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Youmu.NativeFieldInfoPtr_youmuRewardVFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Youmu.NativeFieldInfoPtr_youmuRewardVFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400381B RID: 14363
		private static readonly IntPtr NativeFieldInfoPtr_postiveDuration;

		// Token: 0x0400381C RID: 14364
		private static readonly IntPtr NativeFieldInfoPtr_cuttingboardMultiper;

		// Token: 0x0400381D RID: 14365
		private static readonly IntPtr NativeFieldInfoPtr_negativeDuration;

		// Token: 0x0400381E RID: 14366
		private static readonly IntPtr NativeFieldInfoPtr_passionDecreasePertime;

		// Token: 0x0400381F RID: 14367
		private static readonly IntPtr NativeFieldInfoPtr_passionDecreaseUnitTime;

		// Token: 0x04003820 RID: 14368
		private static readonly IntPtr NativeFieldInfoPtr_patientEditMultiplier;

		// Token: 0x04003821 RID: 14369
		private static readonly IntPtr NativeFieldInfoPtr_youmuRewardVFX;

		// Token: 0x04003822 RID: 14370
		private static readonly IntPtr NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0;

		// Token: 0x04003823 RID: 14371
		private static readonly IntPtr NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x04003824 RID: 14372
		private static readonly IntPtr NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x04003825 RID: 14373
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003826 RID: 14374
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_String_Int32_String_PDM_0;

		// Token: 0x04003827 RID: 14375
		private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__9_1_Private_Void_Int32_0;

		// Token: 0x02000C13 RID: 3091
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Youmu+<OnNegativeBuffExecute>d__8")]
		public sealed class _OnNegativeBuffExecute_d__8 : Il2CppSystem.Object
		{
			// Token: 0x0600E068 RID: 57448 RVA: 0x0036307C File Offset: 0x0036127C
			// Note: this type is marked as 'beforefieldinit'.
			static _OnNegativeBuffExecute_d__8()
			{
				Il2CppClassPointerStore<Spell_Youmu._OnNegativeBuffExecute_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Youmu>.NativeClassPtr, "<OnNegativeBuffExecute>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Youmu._OnNegativeBuffExecute_d__8>.NativeClassPtr);
				Spell_Youmu._OnNegativeBuffExecute_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Youmu._OnNegativeBuffExecute_d__8>.NativeClassPtr, "<>1__state");
				Spell_Youmu._OnNegativeBuffExecute_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Youmu._OnNegativeBuffExecute_d__8>.NativeClassPtr, "<>2__current");
				Spell_Youmu._OnNegativeBuffExecute_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Youmu._OnNegativeBuffExecute_d__8>.NativeClassPtr, "<>4__this");
				Spell_Youmu._OnNegativeBuffExecute_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Youmu._OnNegativeBuffExecute_d__8>.NativeClassPtr, 100680267);
				Spell_Youmu._OnNegativeBuffExecute_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Youmu._OnNegativeBuffExecute_d__8>.NativeClassPtr, 100680268);
				Spell_Youmu._OnNegativeBuffExecute_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Youmu._OnNegativeBuffExecute_d__8>.NativeClassPtr, 100680269);
				Spell_Youmu._OnNegativeBuffExecute_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Youmu._OnNegativeBuffExecute_d__8>.NativeClassPtr, 100680270);
				Spell_Youmu._OnNegativeBuffExecute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Youmu._OnNegativeBuffExecute_d__8>.NativeClassPtr, 100680271);
				Spell_Youmu._OnNegativeBuffExecute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Youmu._OnNegativeBuffExecute_d__8>.NativeClassPtr, 100680272);
			}

			// Token: 0x0600E069 RID: 57449 RVA: 0x0036315C File Offset: 0x0036135C
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnNegativeBuffExecute_d__8(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Youmu._OnNegativeBuffExecute_d__8>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Youmu._OnNegativeBuffExecute_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E06A RID: 57450 RVA: 0x003631A4 File Offset: 0x003613A4
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Youmu._OnNegativeBuffExecute_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E06B RID: 57451 RVA: 0x003631D8 File Offset: 0x003613D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208356, XrefRangeEnd = 208361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Youmu._OnNegativeBuffExecute_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170048E7 RID: 18663
			// (get) Token: 0x0600E06C RID: 57452 RVA: 0x00363214 File Offset: 0x00361414
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Youmu._OnNegativeBuffExecute_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E06D RID: 57453 RVA: 0x00363254 File Offset: 0x00361454
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208361, XrefRangeEnd = 208367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Youmu._OnNegativeBuffExecute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170048E8 RID: 18664
			// (get) Token: 0x0600E06E RID: 57454 RVA: 0x00363288 File Offset: 0x00361488
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Youmu._OnNegativeBuffExecute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E06F RID: 57455 RVA: 0x00077C3C File Offset: 0x00075E3C
			public _OnNegativeBuffExecute_d__8(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170048E4 RID: 18660
			// (get) Token: 0x0600E070 RID: 57456 RVA: 0x003632C8 File Offset: 0x003614C8
			// (set) Token: 0x0600E071 RID: 57457 RVA: 0x00077C45 File Offset: 0x00075E45
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Youmu._OnNegativeBuffExecute_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Youmu._OnNegativeBuffExecute_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170048E5 RID: 18661
			// (get) Token: 0x0600E072 RID: 57458 RVA: 0x003632F0 File Offset: 0x003614F0
			// (set) Token: 0x0600E073 RID: 57459 RVA: 0x00077C60 File Offset: 0x00075E60
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Youmu._OnNegativeBuffExecute_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Youmu._OnNegativeBuffExecute_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170048E6 RID: 18662
			// (get) Token: 0x0600E074 RID: 57460 RVA: 0x00363320 File Offset: 0x00361520
			// (set) Token: 0x0600E075 RID: 57461 RVA: 0x00077C7F File Offset: 0x00075E7F
			public unsafe Spell_Youmu __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Youmu._OnNegativeBuffExecute_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Youmu>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Youmu._OnNegativeBuffExecute_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F95 RID: 36757
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008F96 RID: 36758
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008F97 RID: 36759
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008F98 RID: 36760
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008F99 RID: 36761
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008F9A RID: 36762
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008F9B RID: 36763
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008F9C RID: 36764
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008F9D RID: 36765
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000C14 RID: 3092
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Youmu+<OnPositiveBuffExecute>d__9")]
		public sealed class _OnPositiveBuffExecute_d__9 : Il2CppSystem.Object
		{
			// Token: 0x0600E076 RID: 57462 RVA: 0x00363350 File Offset: 0x00361550
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPositiveBuffExecute_d__9()
			{
				Il2CppClassPointerStore<Spell_Youmu._OnPositiveBuffExecute_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Youmu>.NativeClassPtr, "<OnPositiveBuffExecute>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Youmu._OnPositiveBuffExecute_d__9>.NativeClassPtr);
				Spell_Youmu._OnPositiveBuffExecute_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Youmu._OnPositiveBuffExecute_d__9>.NativeClassPtr, "<>1__state");
				Spell_Youmu._OnPositiveBuffExecute_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Youmu._OnPositiveBuffExecute_d__9>.NativeClassPtr, "<>2__current");
				Spell_Youmu._OnPositiveBuffExecute_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Youmu._OnPositiveBuffExecute_d__9>.NativeClassPtr, "<>4__this");
				Spell_Youmu._OnPositiveBuffExecute_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Youmu._OnPositiveBuffExecute_d__9>.NativeClassPtr, 100680273);
				Spell_Youmu._OnPositiveBuffExecute_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Youmu._OnPositiveBuffExecute_d__9>.NativeClassPtr, 100680274);
				Spell_Youmu._OnPositiveBuffExecute_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Youmu._OnPositiveBuffExecute_d__9>.NativeClassPtr, 100680275);
				Spell_Youmu._OnPositiveBuffExecute_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Youmu._OnPositiveBuffExecute_d__9>.NativeClassPtr, 100680276);
				Spell_Youmu._OnPositiveBuffExecute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Youmu._OnPositiveBuffExecute_d__9>.NativeClassPtr, 100680277);
				Spell_Youmu._OnPositiveBuffExecute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Youmu._OnPositiveBuffExecute_d__9>.NativeClassPtr, 100680278);
			}

			// Token: 0x0600E077 RID: 57463 RVA: 0x00363430 File Offset: 0x00361630
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPositiveBuffExecute_d__9(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Youmu._OnPositiveBuffExecute_d__9>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Youmu._OnPositiveBuffExecute_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E078 RID: 57464 RVA: 0x00363478 File Offset: 0x00361678
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Youmu._OnPositiveBuffExecute_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E079 RID: 57465 RVA: 0x003634AC File Offset: 0x003616AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208367, XrefRangeEnd = 208369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Youmu._OnPositiveBuffExecute_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170048EC RID: 18668
			// (get) Token: 0x0600E07A RID: 57466 RVA: 0x003634E8 File Offset: 0x003616E8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Youmu._OnPositiveBuffExecute_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E07B RID: 57467 RVA: 0x00363528 File Offset: 0x00361728
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208369, XrefRangeEnd = 208375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Youmu._OnPositiveBuffExecute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170048ED RID: 18669
			// (get) Token: 0x0600E07C RID: 57468 RVA: 0x0036355C File Offset: 0x0036175C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Youmu._OnPositiveBuffExecute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E07D RID: 57469 RVA: 0x00077C9E File Offset: 0x00075E9E
			public _OnPositiveBuffExecute_d__9(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170048E9 RID: 18665
			// (get) Token: 0x0600E07E RID: 57470 RVA: 0x0036359C File Offset: 0x0036179C
			// (set) Token: 0x0600E07F RID: 57471 RVA: 0x00077CA7 File Offset: 0x00075EA7
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Youmu._OnPositiveBuffExecute_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Youmu._OnPositiveBuffExecute_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170048EA RID: 18666
			// (get) Token: 0x0600E080 RID: 57472 RVA: 0x003635C4 File Offset: 0x003617C4
			// (set) Token: 0x0600E081 RID: 57473 RVA: 0x00077CC2 File Offset: 0x00075EC2
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Youmu._OnPositiveBuffExecute_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Youmu._OnPositiveBuffExecute_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170048EB RID: 18667
			// (get) Token: 0x0600E082 RID: 57474 RVA: 0x003635F4 File Offset: 0x003617F4
			// (set) Token: 0x0600E083 RID: 57475 RVA: 0x00077CE1 File Offset: 0x00075EE1
			public unsafe Spell_Youmu __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Youmu._OnPositiveBuffExecute_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Youmu>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Youmu._OnPositiveBuffExecute_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F9E RID: 36766
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008F9F RID: 36767
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008FA0 RID: 36768
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008FA1 RID: 36769
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008FA2 RID: 36770
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008FA3 RID: 36771
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008FA4 RID: 36772
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008FA5 RID: 36773
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008FA6 RID: 36774
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
